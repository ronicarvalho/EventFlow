// The MIT License (MIT)
// 
// Copyright (c) 2015-2024 Rasmus Mikkelsen
// https://github.com/eventflow/EventFlow
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using EventFlow.Aggregates;

namespace EventFlow.Subscribers
{
    public class NoDispatchToSubscriberResilienceStrategy : IDispatchToSubscriberResilienceStrategy
    {
        public Task BeforeHandleEventAsync(
            ISubscribe subscriberTo,
            IDomainEvent domainEvent,
            CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task HandleEventFailedAsync(
            ISubscribe subscriberTo,
            IDomainEvent domainEvent,
            Exception exception,
            bool swallowException,
            CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task HandleEventSucceededAsync(
            ISubscribe subscriberTo,
            IDomainEvent domainEvent,
            CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task BeforeDispatchToSubscribersAsync(
            IDomainEvent domainEvent,
            IReadOnlyCollection<IDomainEvent> domainEvents,
            CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task DispatchToSubscribersSucceededAsync(
            IDomainEvent domainEvent,
            IReadOnlyCollection<IDomainEvent> domainEvents,
            CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }

        public Task<bool> HandleDispatchToSubscribersFailedAsync(
            IDomainEvent domainEvent,
            IReadOnlyCollection<IDomainEvent> domainEvents,
            Exception exception,
            CancellationToken cancellationToken)
        {
            return Task.FromResult(false);
        }
    }
}
