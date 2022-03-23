namespace calculatorMain{

    class Program{
        static int saberiBroj(int prvi, int drugi){return prvi + drugi;}
        static int oduzmiBroj(int prvi, int drugi){return prvi - drugi;}

        static float podeliBroj(int prvi, int drugi){
            if(drugi == 0) return -1;
            else return prvi/drugi;

        }
        static void Main(string[] args){
            while(true){
                string text;
                Console.WriteLine("Unesi neku operaciju u formatu broj operacija broj");
                Console.ReadLine(text);
                if(text == "exit" || text == "kraj") break;
                var data= new string[3];
                data = text.Split(' ');
                int prviBroj = Convert.ToInt32(data[0]);
                int drugiBroj = Convert.ToInt32(data[2]);
                char znak = data[1];
                if(znak == '+')Console.WriteLine(saberiBroj(prviBroj, drugiBroj));
                else if(znak == '-')Console.WriteLine(oduzmiBroj(prviBroj, drugiBroj));

            }


        }
    }

}