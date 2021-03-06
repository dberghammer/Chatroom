﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatroomDB
{
    public class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPassword { get; set; }
        public bool isOnline { get; set; }
        public string UserEmail { get; set; }
        public bool isAdmin { get; set; }
        public string UserTag { get; set; }
        public virtual List<Chatroom> UserChatrooms { get; set; }

    }
}
