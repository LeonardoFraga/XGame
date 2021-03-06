﻿using prmToolkit.NotificationPattern;

namespace XGame.Domain.ValueObjects
{
    public class Email : Notifiable
    {
        public Email(string address)
        {
            Address = address;

            new AddNotifications<Email>(this)
                .IfNotEmail(x => x.Address, "E-mail isn't valid.");
        }

        public string Address { get; private set; }
    }
}
