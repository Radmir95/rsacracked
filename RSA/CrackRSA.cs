using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSA
{
    public partial class CrackRSA : Form
    {

        private static List<string> ress = new List<string>();

        private static readonly List<Pair> alpha = new List<Pair>();

        private static readonly List<BigInteger> SPP = new List<BigInteger>();
        //сильно псевдопрростые числа (числа которые прошли тест  на простоту, являясь при этом составными

        private static readonly List<BigInteger> firstPrimes = new List<BigInteger>(); // спсок первых к простых чисел 

        private BigInteger b;

        public CrackRSA()
        {
            InitializeComponent();
            fillSPP();
           
        }

        public static void fillSPP()
        {
            SPP.Add(2047);
            SPP.Add(BigInteger.Parse("1373653"));
            SPP.Add(BigInteger.Parse("25326001"));
            SPP.Add(BigInteger.Parse("3215031751"));
            SPP.Add(BigInteger.Parse("2152302898747"));
            SPP.Add(BigInteger.Parse("3474749660383"));
            SPP.Add(BigInteger.Parse("341550071728321"));
            SPP.Add(BigInteger.Parse("341550071728321"));
            SPP.Add(BigInteger.Parse("3825123056546413051"));
            SPP.Add(BigInteger.Parse("3825123056546413051"));
            SPP.Add(BigInteger.Parse("3825123056546413051"));
            firstPrimes.Add(2);
            firstPrimes.Add(3);
            firstPrimes.Add(5);
            firstPrimes.Add(7);
            firstPrimes.Add(11);
            firstPrimes.Add(13);
            firstPrimes.Add(17);
            firstPrimes.Add(19);
            firstPrimes.Add(23);
            firstPrimes.Add(29);
            firstPrimes.Add(31);
            firstPrimes.Add(37);
            firstPrimes.Add(41);
            firstPrimes.Add(43);
            firstPrimes.Add(47);
            firstPrimes.Add(53);
        }

        public int searchK(BigInteger n) //ищем минимальный индекс к в списке SPP для которых SPP[k] > n
        {
            var k = 0;
            var j = 0;
            while (j < SPP.Count)
            {
                if (SPP[k] < n)
                    k++;
                j++;
            }


            return k;
        }


        private BigInteger Pollard(BigInteger n)
        {

            var start = DateTime.Now.Ticks;

            BigInteger x = 20; //= RandomIntegerBelow(n-2);
            BigInteger y = 1;
            var i = 0;
            var stage = 2;


            while (BigInteger.GreatestCommonDivisor(n, BigInteger.Abs(x - y)) == 1)
            {
                if (i == stage)
                {
                    y = x;
                    stage = stage * 2;
                }
                x = (x * x - 1) % n;
                i = i + 1;
            }

            var result = BigInteger.GreatestCommonDivisor(n, BigInteger.Abs(x - y));

            var end = DateTime.Now.Ticks;

            var timestamp = new TimeSpan(end - start).Seconds;

            timeOfWorking.Text = timestamp.ToString();

            return result;
        }

        public static BigInteger Sqrt(BigInteger n)

        {
            if (n == 0) return 0;
            if (n <= 0) throw new ArithmeticException("NaN");
            var bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
            var root = BigInteger.One << (bitLength / 2);

            while (!isSqrt(n, root))
            {
                root += n / root;
                root /= 2;
            }

            return root;
        }

        public bool Miller_Rabin(BigInteger n) // true если простое 
        {
            if (n <= 1)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;
            var n1 = Sqrt(n);
            if (n1 * n1 == n)
                return false;

            var t = n - 1;
            BigInteger x, a;
            var s = 0;
            while (t % 2 == 0)
            {
                //Представить n − 1 в виде 2s·t, где t нечётно, можно сделать последовательным делением n - 1 на 2.
                s++;
                t = t / 2;
            }
            var k = searchK(n);
            k++;

            for (var i = 0; i < k; i++)
            {

                //a = RandomIntegerBelow(n - 1); // Выбрать случайное целое число a в отрезке [2, n − 2]
                a = firstPrimes[i];
                x = BigInteger.ModPow(a, t, n); // вычисляется с помощью алгоритма возведения в степень по модулю
                if ((x == 1) || (x == n - 1))
                    continue; //то перейти на следующую итерацию цикла А

                var kk = true;

                Parallel.For(0, s - 1, (ii, loopState) =>
                {
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == 1)
                    {
                        kk = false;
                        loopState.Break();
                    }
                    if (x == n - 1)
                        loopState.Break();

                });
                if (!kk)
                    return false;

                if (x != n - 1)
                    return false;
            }

            return true;
        }

        public static bool isSqrt(BigInteger n, BigInteger root)
        {
            var lowerBound = root * root;
            var upperBound = (root + 1) * (root + 1);

            return (n >= lowerBound) && (n < upperBound);
        }
       
        public void showDictionary()
        {
            foreach (var item in alpha)
                answer.Text += item.Letter + " = " + item.Digit + '\n';
        }

        public BigInteger Extended_GCD2(BigInteger n, BigInteger m)
        {
            var Quot = new BigInteger[1000];
            if (n < m)
            {
                BigInteger z;
                z = n;
                n = m;
                m = z;
            }
            var xstep = 1;
            BigInteger r = 1;
            while (r != 0)
            {
                var q = n / m;
                r = n - m * q;
                //    log(" " + n + " = " + m + "*" + q + " + " + r);
                n = m;
                m = r;
                Quot[xstep] = q;
                ++xstep;
            }
            //setgcd(n)
            BigInteger a = 1;
            BigInteger b = 0;
            for (var i = xstep; i > 0; i--)
            {
                var z = b - Quot[i] * a;
                b = a;
                a = z;
            }

            return a;
        }

        private static void GenerateAlhabit()
        {
            var i = 16;

            for (var c = 'А'; c <= 'Я'; c++)
            {
                var p = new Pair
                {
                    Digit = i.ToString(),
                    Letter = c
                };
                alpha.Add(p);
                i++;
            }
            for (var c = 'а'; c <= 'я'; c++)
            {
                var p = new Pair
                {
                    Digit = i.ToString(),
                    Letter = c
                };
                alpha.Add(p);
                i++;
            }
        }

        public static BigInteger GetBigInt(string s) // первеодит строку в число
        {
            var ans = new StringBuilder();
            ans.Append('1');
            foreach (var t in s)
                foreach (var t1 in alpha)
                {
                    if (!t.Equals(t1.Letter)) continue;
                    ans.Append(t1.Digit);
                    break;
                }
            return BigInteger.Parse(ans.ToString());
        }

        public static string GetText(BigInteger b) // первеодит число в строку
        {
            var s = b.ToString();
            var ans = new StringBuilder();
            for (var i = 0; i < s.Length; i = i + 2)
            {
                var temp = s.Substring(i, 2);
                foreach (var t in alpha)
                    if (t.Digit.Equals(temp))
                    {
                        ans.Append(t.Letter);
                        break;
                    }
            }
            return ans.ToString();
        }

        private void CrackRSA_Load(object sender, EventArgs e)
        {
        }

        private void buttonCrack_Click(object sender, EventArgs e)
        {
            GenerateAlhabit(); // создаем алфавит

            if ((textBoxN.Text != "") || (textBoxE.Text != "") || (textBoxSW.Text != "")) //
            {
                MessageBox.Show("Вы не заполнили поля");
            }
            else
            {
                //var n = BigInteger.Parse(textBoxN.Text);

                //var E = BigInteger.Parse(textBoxE.Text);
                //var x = BigInteger.Parse(textBoxSW.Text);


                using (var reader = new System.IO.StreamReader(@"C:\Users\rkhusnut\Desktop\rsacrack-master\RSA\bin\Debug\rsacrack.txt"))
                {
                    int i = 1;
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        var t = BigInteger.Parse(line);
                        Console.WriteLine(t);
                        var k = Pollard(t);
                        var kk = Pollard(t);
                        Console.WriteLine(kk.ToString());
                        ress.Add(kk.ToString());
                        reader.ReadLine();
                        reader.ReadLine();
                        Console.WriteLine(i);
                        i++;
                    }

                }

                System.IO.File.WriteAllLines(@"C:\Users\rkhusnut\Desktop\rsacrack-master\RSA\bin\Debug\rsacrackready.txt", ress);

                //var p = Pollard(n);

                /*var pq = new List<BigInteger>();
                pq.Add(p);
                pq.Add(n/p);

                textBoxP.Text = pq[0].ToString();

                var fi = (pq[0] - 1) * (pq[1] - 1);

                textBoxFi.Text = fi.ToString();

                var d = Extended_GCD2(fi, E);

                textBoxQ.Text = (n/pq[0]).ToString();

                textBoxD.Text = d.ToString();

                // назодим закрытый d, обратное к числу e, по модулю fi, т.ч (e,d)mod(fi)==1
                var y = BigInteger.ModPow(x, d, n);
                
                answer.Text = GetText(y) + '\n';*/
                answer.Text += "ReadY!";
            }
        }
    }
}