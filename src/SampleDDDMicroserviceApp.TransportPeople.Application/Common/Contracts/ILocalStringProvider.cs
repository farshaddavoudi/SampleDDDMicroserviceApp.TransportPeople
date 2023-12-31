﻿namespace SampleDDDMicroserviceApp.TransportPeople.Application.Common.Contracts;

public interface ILocalStringProvider
{
    string? Message(string messageStringsKey);

    string Exception(string exceptionStringsKey);
}