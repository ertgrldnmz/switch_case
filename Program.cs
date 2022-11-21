internal class Program
{
    private static void Main(string[] args)
    {
        int month=DateTime.Now.Month;

        //expression
        switch (month)
        {
            case 1:Console.WriteLine("Ocak"); break;
             case 2:Console.WriteLine("Şubat"); break;
              case 3:Console.WriteLine("Mart"); break;
               case 4:Console.WriteLine("Nisan"); break;
                case 5:Console.WriteLine("Mayıs"); break;
                
        
                    default:Console.WriteLine("yanlış veri girişi");break;
        }

        switch (month)
        {
            case 12: 
            case 1:
            case 2: Console.WriteLine("Kış Ayındasınız");break;

             case 5: 
            case 4:
            case 3: Console.WriteLine("İlkBahar Ayındasınız");break;
            
            case 6: 
            case 7:
            case 8: Console.WriteLine("yaz Ayındasınız");break;
            
            case 9: 
            case 10:
            case 11: Console.WriteLine("Sonbahar Ayındasınız");break;
            
            default: Console.WriteLine("lütfen ay girişini kontrol ediniz");break;
        }

    }
}