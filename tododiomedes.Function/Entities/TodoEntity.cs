﻿using Microsoft.WindowsAzure.Storage.Table;
using System;
using System.Collections.Generic;
using System.Text;

namespace tododiomedes.Function.Entities
{
    public class TodoEntity:TableEntity
    {
        public DateTime CreatedTime { get; set; }

        public string TaskDescription { get; set; }

        public bool IsCompleted { get; set; }

    }
}
