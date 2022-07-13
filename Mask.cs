namespace HelloWorld
{
    public class Mask
    {
        static public void Secret()
        {
            Console.WriteLine("What's Your Secret?");
            string secret = Console.ReadLine();
            string maskedSecret = "";

            if (secret != null)
            {
                if (secret.Length > 4)
                {
                    for (int i = 0; i < secret.Length - 4; i++)
                    {
                        maskedSecret += "*";
                    }

                    maskedSecret += secret[^4..];

                } else
                {
                    Console.WriteLine("Secret Must Be Greater Than 4 Characters!!!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Please Enter A Valid Secret!!!");
                return;
            }
            Console.WriteLine(maskedSecret);
        }
    }
}
