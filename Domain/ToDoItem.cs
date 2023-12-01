using System.ComponentModel.DataAnnotations;

namespace WhatDo.Domain
{
    public class ToDoItem
    {
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}
