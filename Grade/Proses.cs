using System;
namespace Grade
{
    class Proses
    {
        public void Welcome()
        {
            Console.WriteLine("Selamat Datang Di Input Nilai Mahasiswa App!");
            Console.WriteLine("============================================");


        }
        public string InputMhs()
        {
            Console.Write("Masukkan Nama Mahasiswa : ");
            string mhs = Console.ReadLine();
            return mhs;
        }
        public double InputNilai()
        {
            string nTugas, nKuis, nUts, nUas;
            double dTugas = 0, dKuis = 0, dUts = 0 , dUas = 0 , dAkhir;
            double checkNum = -1;
            double[] ret = new double[2];
            ret[0] = 0;
            while (ret[0] == 0)
            {
                Console.Write("Masukkan Nilai Tugas : ");
                nTugas = Console.ReadLine();
                ret = checkNumber(nTugas, checkNum);
                dTugas = ret[1];
                
            }
            ret[0] = 0;
            while (ret[0] == 0)
            {
                Console.Write("Masukkan Nilai Kuis : ");
                nKuis = Console.ReadLine();
                ret = checkNumber(nKuis, checkNum);
                dKuis = ret[1];

            }
            ret[0] = 0;
            while (ret[0] == 0)
            {
                Console.Write("Masukkan Nilai Uts : ");
                nUts = Console.ReadLine();
                ret = checkNumber(nUts, checkNum);
                dUts = ret[1];

            }
            ret[0] = 0;
            while (ret[0] == 0)
            {
                Console.Write("Masukkan Nilai Uas : ");
                nUas = Console.ReadLine();
                ret = checkNumber(nUas, checkNum);
                dUas = ret[1];

            }
            ret[0] = 0;
            dAkhir = (0.2 * dTugas) + (0.2 * dKuis) + (0.3 * dUts) + (0.3 * dUas);
            return dAkhir;
        }
        static double[] checkNumber(string str,double checkNum)
        {
            
            double[] ret = new double[2];
            double newNum;
            ret[0] = 1;
            if (double.TryParse(str, out checkNum))
            {
                newNum = double.Parse(str);
                ret[1] = newNum;
                if (newNum > 100 || newNum < 0)
                {
                    Console.WriteLine("Input HArus > 0 atau < 100!");

                    ret[0] = 0;
                }

            }
            else
            {
                Console.WriteLine("Input Harus Angka!");
                ret[0] = 0;
            }
            return ret;
        }
        public string Kondisi(double nAkhir)
        {
            string nHuruf;
            if (nAkhir >= 85 && nAkhir <= 100)
                nHuruf = "A";
            else if (nAkhir >= 65 && nAkhir < 85)
                nHuruf = "B";
            else if (nAkhir >= 55 && nAkhir < 65)
                nHuruf = "C";
            else if (nAkhir >= 45 && nAkhir < 55)
                nHuruf = "D";
            else if (nAkhir >= 0 && nAkhir <= 45)
                nHuruf = "E";
            else
                nHuruf = "INVALID";
            return nHuruf;
        }
        public void Output(string mhs, string grade)
        {
            Console.Clear();
            Console.WriteLine("Data Nilai Mahasiswa");
            Console.WriteLine("====================");
            Console.WriteLine("Nama Mahasiswa\t:" + mhs);
            Console.WriteLine("Grade\t\t" + grade);
        }
    }
}
