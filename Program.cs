namespace ConsoeleSwitch
{

    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Informe um dia da semana:");
            int x = int.Parse(Console.ReadLine());
            string day;
            switch (x)
            {
                case 1:  day = "Domingo"; break;
                case 2:  day = "Segunda-Feira"; break;
                case 3:  day = "Terça-Feira"; break;
                case 4:  day = "Quarta-Feira"; break;
                case 5:  day = "Quinta-Feira"; break;
                case 6:  day = "Sexta-Feira"; break;
                case 7:  day = "Sábado"; break;                
                default: day = "Nenhum dia  da semana"; break;
            }
            Console.WriteLine(day);
        }
    }
}