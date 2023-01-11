using System;
using System.Text;
public static class myprogram
{
    public static void Main()
    {
        GetDecryption("êōōĦÉōĬįŖuř``ೃಐ಴ೡಟ`ಱ೉ೕ೘ನಟc");
        GetDecryption("౩`ಜ೭ಜನ`శಐೃನ`ೃಱ಺಴ಐಱೃ೭`ಮಐಱ೤ಮ೉ಱ೭ೆ಺ೀc");
        GetDecryption("ౝೀಟಜ೉ಽೀಟಜನೆಟ`ಟಙ಺`ಽ಺ಮಐ`಺ಷ`ಷಟ`೉೘ಟಱ`ಷಐ`ೃಮಱಐಜc");
        GetDecryption("ౚೆಖಟೆ`ಷಐ`ೃಟಮೀಟೆಷೡಫ`ಖ಺ಽೀ಺ೃ®`ౣ಺ಮೀಐ೛ಟಷಷಐ೭`ಥಐಽನೃ೤`಴ಟೆ಺ಜ಺ಖ");
        GetDecryption("఼ಱ೭`ಽ಺ಱ೉ೕಟಷನ೭`ಓಐಱಱ಺ಖ`೉ಜಐಱನೆಟ`ೆಟಱ಺`಴ಟೆ಺ಜಐ`ನ`಺ೆಽೀಐಖ೤ೆಟ");
    }

    public static void GetDecryption(string text)
    {
        char[] message = new   char[text.Length];
        for (int i = 0; i < text.Length; i++)
        {
            message[i] = Convert.ToChar(text[i]);
            int v = message[i] / 3;
           // Console.OutputEncoding = Encoding.UTF8;
            Console.Write(Convert.ToChar(v));
        }
        Console.Write("\n");
    }
}