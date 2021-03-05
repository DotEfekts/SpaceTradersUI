﻿namespace SpaceTraders_Client.Providers
{
    public class UtilityProvider
    {
        private readonly ConsoleOutput _console;

        public UtilityProvider(
            CommandHandler commandHandler,
            ConsoleOutput console
            )
        {
            _console = console;
            commandHandler.RegisterCommand("CLEAR", HandleClear);
        }

        private void HandleClear(string[] args)
        {
            _console.Clear();
        }
    }
}
