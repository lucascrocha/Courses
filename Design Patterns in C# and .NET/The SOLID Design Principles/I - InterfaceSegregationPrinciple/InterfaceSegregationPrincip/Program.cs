using System;

namespace InterfaceSegregationPrincip
{
    interface IMachine
    {
        void Print(Document document);
        void Scan(Document document);
        void Fax(Document document);
    }

    interface IPrinter
    {
        void Print(Document document);
    }

    interface IScanner
    {
        void Scan(Document document);
    }

    interface IFax
    {
        void Fax(Document document);
    }

    interface IMultiFunctionDevice : IScanner, IPrinter
    {

    }

    class MultiFunctionMachine : IMultiFunctionDevice
    {
        private IPrinter printer;
        private IScanner scanner;

        public MultiFunctionMachine(IPrinter printer, IScanner scanner)
        {
            this.printer = printer;
            this.scanner = scanner;
        }

        public void Print(Document d)
        {
            printer.Print(d);
        }

        public void Scan(Document d)
        {
            scanner.Scan(d);
        }
    }

    class Photocopier : IPrinter, IScanner
    {
        public void Print(Document document)
        {
            
        }

        public void Scan(Document document)
        {
            
        }
    }

    class MultiFunctionPrinter : IMachine
    {
        public void Fax(Document document)
        {

        }

        public void Print(Document document)
        {

        }

        public void Scan(Document document)
        {

        }
    }

    class OldPrinter
    {

    }

    class Document
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}