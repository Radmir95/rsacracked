using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using System.Security.Cryptography;

namespace RSA
{
   


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            fillSPP();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        static List<Pair> alpha = new List<Pair>();
        static List<BigInteger> SPP = new List<BigInteger>();//сильно псевдопрростые числа (числа которые прошли тест  на простоту, являясь при этом состваными
        static List<BigInteger> firstPrimes = new List<BigInteger>(); // спсок первых к простых чисел 
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
            firstPrimes.Add(2); firstPrimes.Add(3); firstPrimes.Add(5); firstPrimes.Add(7);  
            firstPrimes.Add(11); firstPrimes.Add(13); firstPrimes.Add(17); firstPrimes.Add(19);
            firstPrimes.Add(23); firstPrimes.Add(29); firstPrimes.Add(31); firstPrimes.Add(37);
            firstPrimes.Add(41); firstPrimes.Add(43); firstPrimes.Add(47); firstPrimes.Add(53);
        }
        public int searchK(BigInteger n)//ищем минимальный индекс к в списке SPP для которых SPP[k] > n
        { 
            int k = 0;
            int j = 0;
            while (j < SPP.Count)
            {
                if (SPP[k] < n)
                    k++;
                j++;
            }
            
            
            return k;
        
        
        }

        private static void GenerateAlhabit()
        {
            int i = 0;

            for (char c = 'a'; c <= 'я'; c++) { 
             Pair p = new Pair()
                {
                    Digit = (i < 10) ? ('0' + i.ToString()).ToString() : i.ToString(),
                    Letter = c
                };
                alpha.Add(p);
                i++;
            
            }
        }
        public static BigInteger GetBigInt(string s) // первеодит строку в число
        {
            StringBuilder ans = new StringBuilder();
            ans.Append('1');
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = 0; j < alpha.Count; j++)
                {
                    if (s[i].Equals(alpha[j].Letter))
                    {
                        ans.Append(alpha[j].Digit);
                        break;
                    }
                }
            }
            return  BigInteger.Parse(ans.ToString());
        }
        public static string GetText(BigInteger b) // первеодит число в строку
        {
            string s = b.ToString();
            StringBuilder ans = new StringBuilder();
            for (int i = 1; i < s.Length; i = i + 2)
            {
                string temp = s.Substring(i, 2);
                for (int j = 0; j < alpha.Count; j++)
                {
                    if (alpha[j].Digit.Equals(temp)) 
                    {
                        ans.Append(alpha[j].Letter);
                        break;
                    }
                }
            }
            return ans.ToString();
        }


        
        public  BigInteger generatePrime(BigInteger n) // возваражет простое в диапозоне до n
        {
            BigInteger number = RandomIntegerBelow(n);
            while(true){
                if (Miller_Rabin(number))// если простое 
                    break;
                else
                {
                    number = RandomIntegerBelow(n);
                }

            }
            return number;
        }
         
        public BigInteger RandomIntegerBelow(BigInteger bound)
        {
            var rng = new RNGCryptoServiceProvider();
            //Получили буфер байтов, способный содержащий любое значение ниже границы
            var buffer = (bound << 16).ToByteArray(); //<< 16 добавляет два байта, которые уменьшают вероятность повторить попытку позже

            //Вычислим где начинается последний частичный фрагмент, для того, чтобы повторить попытку, если мы в конечном итоге в нем
            var generatedValueBound = BigInteger.One << (buffer.Length * 8 - 1); //-1 accounts for the sign bit
            var validityBound = generatedValueBound - generatedValueBound % bound;

            while (true)
            {
                // Генерировать равномерно случайное значение в [0, 2 ^ (buffer.Length * 8 - 1))
                rng.GetBytes(buffer);
                buffer[buffer.Length - 1] &= 0x7F; 
                var r = new BigInteger(buffer);

                // если не указано в частичном фрагменте
                if (r >= validityBound) continue;
                return r % bound;
            }
        }
        public  bool Miller_Rabin(BigInteger n) // true если простое 
        {
            //BigInteger u = n.Substract(One);
            if (n <= 1)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;
            BigInteger  n1 = Sqrt(n);
            if (n1 * n1 == n) {
                return false;
            }
            
            BigInteger t = n - 1;
            BigInteger x, a;
            int s = 0;
            while (t % 2 == 0)
            {//Представить n − 1 в виде 2s·t, где t нечётно, можно сделать последовательным делением n - 1 на 2.
                s++;
                t = t/2;
            }
            int k = searchK(n);
            k++;
           
           for (int i = 0; i < k; i++) {// цикл А повторить k раз:
                 
                //a = RandomIntegerBelow(n - 1); // Выбрать случайное целое число a в отрезке [2, n − 2]
                a = firstPrimes[i];
                x = BigInteger.ModPow(a, t, n);// вычисляется с помощью алгоритма возведения в степень по модулю
                if (x == 1 || x == n - 1)
                    continue; //то перейти на следующую итерацию цикла А
                for (int j = 0; j < s - 1; j++) { // Цикл B  повторить s − 1 раз
                    x = BigInteger.ModPow(x, 2, n);
                    if (x == 1)
                        return false; // то вернуть составное
                    if (x == n - 1)
                        break; // то перейти на следующую итерацию цикла A
                
                }
                if (x != n - 1)
                    return false;
           }

           return true;
        }
        public void generateP_and_Q(ref BigInteger p, ref BigInteger q) {

            BigInteger n = BigInteger.Parse("1000000000000000000000000000000000000000000");//43символа
            if (p_text.Text == "") // если мы ничего не ввели
                p = generatePrime(n);
            else
            {
                p = BigInteger.Parse(p_text.Text);
                if (!Miller_Rabin(p))// если не простое 
                    p = generatePrime(p);
            }
            if (q_text.Text == "") // если мы ничего не ввели
                q = generatePrime(n);
            else
            {
                q = BigInteger.Parse(q_text.Text);
                if (!Miller_Rabin(q))// если простое 
                    q = generatePrime(q);
            }
        
        
        }
        
        public void showDictionary ()
        {
            foreach (var item in alpha)
            {
                answer.Text += item.Letter+ " = " + item.Digit+ '\n';
            
            }
        
        
        }
        public BigInteger Extended_GCD2(BigInteger n, BigInteger m)
        {
            BigInteger[] Quot = new BigInteger[1000];
            if (n < m)
            {
                BigInteger z;
                z = n;
                n = m;
                m = z;
            }
            BigInteger originaln = n;
            BigInteger originalm = m;
            int xstep = 1;
            BigInteger r = 1;
            while (r != 0)
            {
                BigInteger q = n / m;
                r = n - m * q;
            //    log(" " + n + " = " + m + "*" + q + " + " + r);
                n = m;
                m = r;
                Quot[xstep] = q;
                ++xstep;
            }
            //setgcd(n)
            BigInteger gcd = n;
            BigInteger a = 1;
            BigInteger b = 0;
            for (int i = xstep; i > 0; i--)
            {
                BigInteger z = b - Quot[i] * a;
                b = a;
                a = z;
            }

            return a;
        }
        public static BigInteger Sqrt(BigInteger n)
        {
            if (n == 0) return 0;
            if (n > 0)
            {
                int bitLength = Convert.ToInt32(Math.Ceiling(BigInteger.Log(n, 2)));
                BigInteger root = BigInteger.One << (bitLength / 2);

                while (!isSqrt(n, root))
                {
                    root += n / root;
                    root /= 2;
                }

                return root;
            }

            throw new ArithmeticException("NaN");
        }
        public static Boolean isSqrt(BigInteger n, BigInteger root)
        {
            BigInteger lowerBound = root * root;
            BigInteger upperBound = (root + 1) * (root + 1);

            return (n >= lowerBound && n < upperBound);
        }
        public  List<BigInteger> Factorization2(BigInteger a)
        {
            
            List<BigInteger> otvet = new List<BigInteger>();
            if (Miller_Rabin(a))
            {
                otvet.Add(a);
                return otvet;
            }

            BigInteger b = a;
            for (int i = 2; i < 100; i++)
            {
                BigInteger temp = i; // new BigInteger(i.ToString());
                
                if ( b % temp == 0)
                {
                    otvet.AddRange(Factorization2(temp));
                    b = b / temp;
                    otvet.AddRange(Factorization2(b));
                    return otvet;
                }
            }
            return Factorization(a);
        }
        public  List<BigInteger> Factorization(BigInteger a)
        {
            List<BigInteger> otvet = new List<BigInteger>();
            BigInteger temp = a;
            while (!Miller_Rabin(temp))
            {
                BigInteger temp2 = Pollard(temp);
                if (temp == temp2)
                {
                    continue;
                }
                if (Miller_Rabin(temp2))
                {
                    otvet.Add(temp2);
                }
                else
                {
                    otvet.AddRange(Factorization(temp2));
                }
                temp = temp/temp2;
            }
            otvet.Add(temp);
            return otvet;
        }
        private  BigInteger PollardRho(BigInteger n)
        {
            int i = 1;
            BigInteger x = 2;
            BigInteger y = 2;
            int k = 2;
            while (true)
            {
                i++;
                if (i > 1000000)
                {
                    return n;
                }

                x = (x * x + 1) % n;
                BigInteger temp = y + x;
                if (temp<0)
                {
                    temp = temp * (-1);
                }
                BigInteger d = BigInteger.GreatestCommonDivisor(temp, n);
                if (d != 1 && d !=n)
                {
                    return d;
                }
                if (i == k)
                {
                    y = x;
                    k = 2 * k;
                }
            }
        }
        private BigInteger Pollard(BigInteger n)
        {
            BigInteger x = 2;//RandomIntegerBelow(n-2);
            BigInteger y = 1;   
            int i = 0; 
            int stage = 2;


            while (BigInteger.GreatestCommonDivisor(n, BigInteger.Abs(x - y)) == 1)
                 {
                    if (i == stage )
                    {
                       y = x;
                    stage = stage*2; 
                   }
                     x = (x *x - 1) % n;
                     i = i + 1;
       }
            answer.Text += " i = " +i.ToString() + " ";
            

     return BigInteger.GreatestCommonDivisor(n, BigInteger.Abs(x - y));
       
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            BigInteger n = BigInteger.Parse("2015638500984252513380255580199");
       //  BigInteger h =   Pollard(n);
         //answer.Text = h.ToString();
           List<BigInteger> otvet = Factorization2(n);

           foreach (var item in otvet)
          {
              answer.Text += item.ToString() + " ";
            
           }
            */
            
            BigInteger q = 0;
            BigInteger p = 0;
            BigInteger n;
            BigInteger fi;
            BigInteger E;
            BigInteger d;
            BigInteger codedM;
            BigInteger decodedM;
            GenerateAlhabit(); // создали алфавит
   
            generateP_and_Q(ref p, ref q); // генерируем p and q

            p_text.Text = p.ToString();
            q_text.Text = q.ToString();
            n = p * q; // находим n
            fi = (p - 1) * (q - 1); // находим fi
            E = RandomIntegerBelow(n); // генерируем е < n такое что (е,fi) == 1
            e_text.Text = E.ToString();
            while (BigInteger.GreatestCommonDivisor(E, fi) != 1) // если (е,fi) != 1 
                E = RandomIntegerBelow(n); // перегенирируем
            e_text.Text = E.ToString();
            fi_text.Text = fi.ToString();

            d = Extended_GCD2(fi, E); // назодим закрытый d, обратное к числу e, по модулю fi, т.ч (e,d)mod(fi)==1
               if (d < 0)
                    d = d + fi;
            d_text.Text = d.ToString();

            string mes = message.Text; // берем сообщение из окна
            if (mes == "")
            {
                MessageBox.Show(" Вы не ввели сообщение");
                return;
            }
            // будем разбивать сообщения на блоки различной длины, чтобы выполнялось M < n
            int blockLength = 0; // размер блока
            BigInteger M = 0;  //цифровое значение блока
            for (int i = 0; i < mes.Count(); i = i + blockLength) {// i - с какой позиции начинается очередной блок
                blockLength = 0;
                M = 0;
                while (M < n ) // шифремое M должно бить меньше n
                {
                    if (mes.Count() == i + blockLength) // если мы дошли до конца сообщения
                        break;
                    else
                    blockLength++; // увеличивае размер блока
                    BigInteger temp = GetBigInt(mes.Substring(i, blockLength));// //считаем длинное число от размера блока 
                    if (temp >= n) // если оно больше n
                    {
                        blockLength--; // уменьшаем размер блока
                        break;
                    }
                    M = temp; 
                
                }


            answer.Text+="блок сообщения = " + mes.Substring(i, blockLength)+'\n';
            codedM = BigInteger.ModPow(M, E, n); // шифруем поблочно codedM = M^e modn
            decodedM = BigInteger.ModPow(codedM, d, n); // дешифруем decodedM = codedM^d modn
            answer.Text += "блок сообщения M = " + M.ToString() + '\n';
            answer.Text += "зашифрованное сообщение = "+codedM.ToString()+'\n';
            answer.Text += "расшифрованный блок = " + decodedM.ToString()+'\n';
            decrypt.Text += GetText(decodedM); // переводим расшивроавнное число в строку
            }

           
            


        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void q_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void p_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void mBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public class Pair
    {
        public char Letter;//буква
        public string Digit;//цифровое представление
    }
}
