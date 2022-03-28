namespace EzivnostC
{
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Drawing;
    using global::System.IO;
    using global::System.Linq;
    using global::System.Net.Http;
    using global::System.Threading;
    using global::System.Threading.Tasks;
    using global::System.Windows.Forms;
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {  

           
            Welcome welcome = new Welcome();
            
            Application.Run(welcome);
            
            
        }
    }
}