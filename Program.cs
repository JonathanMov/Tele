using System;

    class Canal{
        private string nombre,pantalla;
        private int no;
        public void captura_canal(string nom,int n, string pan){
            this.nombre=nom;
            this.no=n;
            this.pantalla=pan;
        }
        public void ver(){
            Console.WriteLine("\n\nEstas Viendo el Canal: "+ no+" ("+nombre+")\n"+pantalla);
        }
        
    }
    class Program{
        static void Main(){
            int i;
            Console.Write("Presiona la tecla Home para prender ");
            Canal Azteca1=new Canal();
            Azteca1.captura_canal("Azteca 1",1,"   *******\n   *00100*\n   *00100*\n   *******");

            Canal Estrellas=new Canal();
            Estrellas.captura_canal("El Canal de la Estrellas",2,"   *******\n   *00200*\n   *00200*\n   *******");

            Canal Once=new Canal();
            Estrellas.captura_canal("El Canal de la Estrellas",2,"   *******\n   *00200*\n   *00200*\n   *******");
            
            if (Console.ReadKey().Key==ConsoleKey.Home){
                Console.WriteLine("\nPrendiendo tele...\n   *******\n   *     *\n   *     *\n   *******");
                
                do{
                    Console.Write("Elige un canal: ");
                    i=Int32.Parse(Console.ReadLine());

                switch (i){
                    case 1:
                    Azteca1.ver();
                    break;

                    case 2:
                    Estrellas.ver();
                    break;

                    case 3:
                    Once.ver();
                    break;

                    case 10:
                    Console.WriteLine("Apagando tele...");
                    break;

                    default:
                    Console.WriteLine("No has pagado para ver ese canal");
                    break;
                    }
                }while(i<10);
            }
            else Console.WriteLine("\nNo pudiste prender la TELE");
            
        }
    }

