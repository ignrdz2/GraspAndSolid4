namespace Full_GRASP_And_SOLID;

public class PrinterCreator
{
    public static IPrinter CreateConsolePrinter()
    {
        return new ConsolePrinter();
    }
    public static IPrinter CreateFilePrinter(){
        return new FilePrinter();
    }
}