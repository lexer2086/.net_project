using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Films
    {
        public virtual int Id { get; set; }
        public virtual string Title { get; set; }
    }
}