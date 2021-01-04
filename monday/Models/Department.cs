﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mondayWebApp.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        public string DepartmentName { get; set; }
        public string DepartmentDesc { get; set; }
        public DateTime DepartmentEstablishmentDate { get; set; }
        public  Employee DepartmentManager { get; set; }

        // Pracownicy działu
        public ICollection<Employee> Employees { get; set; }

        // Blokuje rekord przed edycją
        public bool IsEdited { get; set; }

        // Wskazuje czy zaznazono rekord
        public bool IsChecked { get; set; }
    }
}
