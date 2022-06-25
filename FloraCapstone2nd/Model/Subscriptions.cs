﻿namespace FloraCapstone2nd.Model
{
    public class Subscriptions
    {
        public int SubscriptionID { get; set; }
        public string SubscriptionType { get; set; }
        public string Description { get; set; }
        public DateTime SubscriptionLength { get; set; }
        public int SubscriptionPrice { get; set; }
        public char PaymentAccNum { get; set; }
        public DateTime DateAdded { get; set; }

    }
}