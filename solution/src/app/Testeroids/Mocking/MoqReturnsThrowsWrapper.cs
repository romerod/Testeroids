// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MoqReturnsThrowsWrapper.cs" company="Testeroids">
//   � 2012-2013 Testeroids. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------
namespace Testeroids.Mocking
{
    using System;
    using System.Linq.Expressions;

    using Moq.Language;
    using Moq.Language.Flow;

    internal class MoqReturnsThrowsWrapper<TMock, TResult> : Moq.Language.Flow.IReturnsThrows<TMock, TResult>
        where TMock : class
    {
        #region Fields

        private readonly LambdaExpression expression;

        private readonly IVerifiedMock testeroidsMock;

        private readonly IReturnsThrows<TMock, TResult> wrappedReturnsThrows;

        #endregion

        #region Constructors and Destructors

        public MoqReturnsThrowsWrapper(
            LambdaExpression expression, 
            IReturnsThrows<TMock, TResult> wrappedReturnsThrows, 
            IVerifiedMock testeroidsMock)
        {
            this.expression = expression;
            this.wrappedReturnsThrows = wrappedReturnsThrows;
            this.testeroidsMock = testeroidsMock;
        }

        #endregion

        #region Public Methods and Operators

        /// <inheritdoc/>
        IReturnsResult<TMock> IReturns<TMock, TResult>.Returns(TResult value)
        {
            return this.wrappedReturnsThrows.Returns(value);
        }

        /// <inheritdoc/>
        IReturnsResult<TMock> IReturns<TMock, TResult>.Returns(Func<TResult> valueFunction)
        {
            return this.wrappedReturnsThrows.Returns(valueFunction);
        }

        /// <inheritdoc/>
        IReturnsResult<TMock> IReturns<TMock, TResult>.Returns<T1>(Func<T1, TResult> valueFunction)
        {
            return this.wrappedReturnsThrows.Returns(valueFunction);
        }

        /// <inheritdoc/>
        IReturnsResult<TMock> IReturns<TMock, TResult>.Returns<T1, T2>(Func<T1, T2, TResult> valueFunction)
        {
            return this.wrappedReturnsThrows.Returns(valueFunction);
        }

        /// <inheritdoc/>
        IReturnsResult<TMock> IReturns<TMock, TResult>.Returns<T1, T2, T3>(Func<T1, T2, T3, TResult> valueFunction)
        {
            return this.wrappedReturnsThrows.Returns(valueFunction);
        }

        /// <inheritdoc/>
        IReturnsResult<TMock> IReturns<TMock, TResult>.Returns<T1, T2, T3, T4>(Func<T1, T2, T3, T4, TResult> valueFunction)
        {
            return this.wrappedReturnsThrows.Returns(valueFunction);
        }

        /// <inheritdoc/>
        IReturnsResult<TMock> IReturns<TMock, TResult>.Returns<T1, T2, T3, T4, T5>(Func<T1, T2, T3, T4, T5, TResult> valueFunction)
        {
            return this.wrappedReturnsThrows.Returns(valueFunction);
        }

        /// <inheritdoc/>
        IReturnsResult<TMock> IReturns<TMock, TResult>.Returns<T1, T2, T3, T4, T5, T6>(Func<T1, T2, T3, T4, T5, T6, TResult> valueFunction)
        {
            return this.wrappedReturnsThrows.Returns(valueFunction);
        }

        /// <inheritdoc/>
        IReturnsResult<TMock> IReturns<TMock, TResult>.Returns<T1, T2, T3, T4, T5, T6, T7>(Func<T1, T2, T3, T4, T5, T6, T7, TResult> valueFunction)
        {
            return this.wrappedReturnsThrows.Returns(valueFunction);
        }

        /// <inheritdoc/>
        IReturnsResult<TMock> IReturns<TMock, TResult>.Returns<T1, T2, T3, T4, T5, T6, T7, T8>(Func<T1, T2, T3, T4, T5, T6, T7, T8, TResult> valueFunction)
        {
            return this.wrappedReturnsThrows.Returns(valueFunction);
        }

        /// <inheritdoc/>
        IReturnsResult<TMock> IReturns<TMock, TResult>.Returns<T1, T2, T3, T4, T5, T6, T7, T8, T9>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, TResult> valueFunction)
        {
            return this.wrappedReturnsThrows.Returns(valueFunction);
        }

        /// <inheritdoc/>
        IReturnsResult<TMock> IReturns<TMock, TResult>.Returns<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, TResult> valueFunction)
        {
            return this.wrappedReturnsThrows.Returns(valueFunction);
        }

        /// <inheritdoc/>
        IReturnsResult<TMock> IReturns<TMock, TResult>.Returns<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, TResult> valueFunction)
        {
            return this.wrappedReturnsThrows.Returns(valueFunction);
        }

        /// <inheritdoc/>
        IReturnsResult<TMock> IReturns<TMock, TResult>.Returns<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, TResult> valueFunction)
        {
            return this.wrappedReturnsThrows.Returns(valueFunction);
        }

        /// <inheritdoc/>
        IReturnsResult<TMock> IReturns<TMock, TResult>.Returns<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, TResult> valueFunction)
        {
            return this.wrappedReturnsThrows.Returns(valueFunction);
        }

        /// <inheritdoc/>
        IReturnsResult<TMock> IReturns<TMock, TResult>.Returns<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, TResult> valueFunction)
        {
            return this.wrappedReturnsThrows.Returns(valueFunction);
        }

        /// <inheritdoc/>
        IReturnsResult<TMock> IReturns<TMock, TResult>.Returns<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, TResult> valueFunction)
        {
            return this.wrappedReturnsThrows.Returns(valueFunction);
        }

        /// <inheritdoc/>
        IReturnsResult<TMock> IReturns<TMock, TResult>.Returns<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16>(Func<T1, T2, T3, T4, T5, T6, T7, T8, T9, T10, T11, T12, T13, T14, T15, T16, TResult> valueFunction)
        {
            return this.wrappedReturnsThrows.Returns(valueFunction);
        }

        /// <inheritdoc/>
        IThrowsResult IThrows.Throws(Exception exception)
        {
            var returnsThrows = this.wrappedReturnsThrows.Throws(exception);
            return new MoqThrowsResult(this.expression, returnsThrows, this.testeroidsMock);
        }

        /// <inheritdoc/>
        IThrowsResult IThrows.Throws<TException>()
        {
            var returnsThrows = this.wrappedReturnsThrows.Throws<TException>();
            return new MoqThrowsResult(this.expression, returnsThrows, this.testeroidsMock);
        }

        #endregion
    }
}