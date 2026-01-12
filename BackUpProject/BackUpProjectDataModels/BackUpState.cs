using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BackUpProject.BackUpProjectDataModels
{
    public class BackUpState
    {
        public BackUpState()
        {

        }

        [Key]
        public int Id { get; set; }
        public string DbName { get; set; }
        public int Timer { get; set; }
        public bool StateIsOn { get; set; }
        public DateTime LastBackUp { get; set; }

    }
}
