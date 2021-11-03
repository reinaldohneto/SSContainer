﻿using System.ComponentModel.DataAnnotations;

public class UserLoginRequest
{
    [Required]
    public string Email { get; set; }
    [Required]
    public string Senha { get; set; }
}