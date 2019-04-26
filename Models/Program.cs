using InstaSharper.API;
using InstaSharper.API.Builder;
using InstaSharper.Classes;
using InstaSharper.Logger;
using System;


namespace InstaTeste
{
    public class Program
    {

        #region Hidden
        private const string username = "";
        private const string password = "";
        #endregion
        private static UserSessionData user;
        private static IInstaApi api;

        static void Main(string[] args)
        {
            user = new UserSessionData();
            user.UserName = username;
            user.Password = password;
            Login();
        }

        public static async void Login()
        {

            api = InstaApiBuilder.CreateBuilder().SetUser(user)
                    .UseLogger(new DebugLogger(LogLevel.Exceptions))
                    //.SetRequestDelay(TimeSpan.FromSeconds(8))
                    .Build();

            var loginRequest = await api.LoginAsync();

            if (loginRequest.Succeeded)
            {
                Console.WriteLine("Logado");
            }
            else
            {
                Console.WriteLine("Erro: {0}", loginRequest.Info.Message);
            }
        }


    }
}



