﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftTradePlusStore.Models.Products;

namespace SoftTradePlusStore.Models.Clients
{
    internal class Entity : Client
    {
        public Individual Individual { get; set; }
        public Entity() { }

        public Entity(bool newItem) : base(newItem) { }

        public Entity(string name, ClientStatus status, Manager manager, ObservableCollection<BoughtProduct> products, Individual individual) : base(name, status, manager, products)
        {
            Individual = individual;
        }
    }
}
