# Switch case Yapısı
##### Switch-Case ifadelerinde dikkat edilmesi gereken durumlar aşağıdaki gibidir:

>- Case ifadelerinin sırası önemli değildir.
 >- Bilinenin aksine default ifadesi en son yazılmak zorunda değildir.
>- Default ifadesi zorunlu değildir. Yazılmasa da olur.

##### Örnek kullanım

```csharp

switch (month)
        {
            case 1:Console.WriteLine("Ocak"); break;
             case 2:Console.WriteLine("Şubat"); break;
              case 3:Console.WriteLine("Mart"); break;
               case 4:Console.WriteLine("Nisan"); break;
                case 5:Console.WriteLine("Mayıs"); break;
                
        
                    default:Console.WriteLine("yanlış veri girişi");break;
        }

```
[www.patika.dev](https://www.patika.dev/tr)
