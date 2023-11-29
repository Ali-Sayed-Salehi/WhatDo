﻿namespace WhatDo.Server.DTOs
{
    public class ToDoItemDto
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }
    }
}