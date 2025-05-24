using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

using practica3.Dto;


namespace practica3.Models
{
    public class PostDetailViewModel
    {
        public Post Post { get; set; } = new();
        public User? User { get; set; }
        public List<Comment> Comments { get; set; } = new();
    }
}