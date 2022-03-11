using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kelulusan
{
    /// <summary>
    /// Input dan Output Class
    /// </summary>
    /// 
    class Inputoutput
    {
        
        public double mtk, ipa, rata;

        /// <summary>
        /// input Nilai 
        /// </summary>
        public void Masukkandata()
        {
            Console.Write("Masukkan Nilai Matematika = ");
            mtk = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan nilai IPA = ");
            ipa = Convert.ToDouble(Console.ReadLine());
        }

        /// <summary>
        /// Output 
        /// </summary>
        public void tampilan()
        {
            Console.WriteLine("Hasil test anda dengan nilai mtk dan rata rata {0},{1} = {02}", mtk, ratailai(), dinyatakanLulus());
        }
        
        /// <summary>
        /// operasi rata rata
        /// </summary>
        /// <returns>hasil dari penjumlahan dan pembagian angka pertama dan kedua</returns>
        public double ratailai()
        {
            return (mtk + ipa) / 2;
        }

        /// <summary>
        /// operasi nilai dianggap lulus atau tidak
        /// </summary>
        /// <returns>disini hasil dari penjumlahan tadi di golongkan apakah nilai tadi lulus atau tidak</returns>
        public string dinyatakanLulus()
        {
            string status;

            if ((mtk >= 80.00) && (ratailai() >= 75.00))
            {
                status = "Anda dinyatakan lulus";
            }
            else
            {
                status = "Anda dinyatakan tidak lulus";
            }
            return status;
        }

    }

    /// <summary>
    /// Main class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Inputoutput ip = new Inputoutput();
            ip.Masukkandata();
            ip.tampilan();
            ip.dinyatakanLulus();
            Console.ReadKey();
        }
    }
}
