﻿namespace AccountService.ServiceHost.Controllers.Dto.LoginUser;

public class LoginUserRequest
{
    public required string Email { get; init; }

    public required string Password { get; init; }
}
