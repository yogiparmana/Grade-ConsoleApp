using System;

namespace Grade
{
    class Program
    {
        static void Main(string[] args)
        {
            Proses proses = new Proses();
            proses.Welcome();
            string mhs = proses.InputMhs();
            double nAkhir =  proses.InputNilai();
            string grade = proses.Kondisi(nAkhir);
            proses.Output(mhs,grade);
            

        }
        

    }
}
