using StringEncrypter;

StringEncrypterService stringEncrypterService = new();

try
{
    var method = args[0]; // Enter either "e" or "d" to determine whether to encrypt or decrypt respectively
    var stringToEncryptOrDecrypt = args[1];

    Console.WriteLine($"Input string: {stringToEncryptOrDecrypt}");

    switch (method)
    {
        case "e":
            Console.WriteLine($"Encrypted string: {stringEncrypterService.EncryptDecode("e", stringToEncryptOrDecrypt)}");
            break;
        case "d":
            Console.WriteLine($"Decrypted string: {stringEncrypterService.EncryptDecode("d", stringToEncryptOrDecrypt)}");
            break;
        default:
            throw new Exception();
    }
}
catch (Exception e)
{
    Console.WriteLine(e);
}