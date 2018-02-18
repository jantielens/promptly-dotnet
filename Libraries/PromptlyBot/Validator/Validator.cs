﻿using Microsoft.Bot.Builder;

namespace AlarmBot.Promptly.Validator
{
    public class ValidatorResult<TValue>
    {
        public TValue Value { get; set; }
        public string Reason { get; set; }
    }

    public abstract class Validator<TValue>
    {
        public abstract ValidatorResult<TValue> Validate(IBotContext context);
    }
}
