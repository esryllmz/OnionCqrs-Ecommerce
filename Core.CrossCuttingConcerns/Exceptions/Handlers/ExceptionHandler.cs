﻿using Core.CrossCuttingConcerns.Exceptions.ExceptionTypes;

namespace Core.CrossCuttingConcerns.Exceptions.Handlers;

public abstract class ExceptionHandler
{
  public Task HandleExceptionAsync(Exception exception) => exception switch
  {
    BusinessException businessException => HandleException(businessException),
    ValidationException validationException => HandleException(validationException),
    AuthorizationException authorizationException => HandleException(authorizationException),
    _ => HandleException(exception)
  };

  protected abstract Task HandleException(AuthorizationException authorizationException);

  protected abstract Task HandleException(ValidationException validationException);

  protected abstract Task HandleException(BusinessException businessException);

  protected abstract Task HandleException(Exception exception);
}