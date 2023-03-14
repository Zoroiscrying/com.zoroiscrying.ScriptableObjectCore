using System;
using UnityEngine;

namespace com.zoroiscrying.ScriptableObjectCore
{
    public abstract class FunctionSO<TR> : BaseSO
    {
        /// <summary>
        /// The actual function.
        /// </summary>
        [HideInInspector]
        public Func<TR> Func;

        /// <summary>
        /// Call the function
        /// </summary>
        /// <returns>The function that would return with the type TR</returns>
        /// <exception cref="Exception"></exception>
        public virtual TR Call()
        {
            if (Func != null)
            {
                return Func();
            }

            throw new Exception("Either set Func or override the Call method.");
        }

        /// <summary>
        /// Set the Function providing a `Func&lt;R&gt;`
        /// </summary>
        /// <param name="func">The `Func&lt;TR&gt;` to set.</param>
        /// <returns>An `FunctionSO&lt;TR&gt;`.</returns>
        public FunctionSO<TR> SetFunc(Func<TR> func)
        {
            Func = func;
            return this;
        }
    }

    public abstract class FunctionSO<TR, T1> : BaseSO
    {
        /// <summary>
        /// The actual function.
        /// </summary>
        [HideInInspector]
        public Func<T1, TR> Func;

        /// <summary>
        /// Call the function
        /// </summary>
        /// <returns>The function that would return with the type TR</returns>
        /// <exception cref="Exception"></exception>
        public virtual TR Call(T1 t1)
        {
            if (Func != null)
            {
                return Func(t1);
            }

            throw new Exception("Either set Func or override the Call method.");
        }

        /// <summary>
        /// Set the Function providing a `Func&lt;R&gt;`
        /// </summary>
        /// <param name="func">The `Func&lt;TR&gt;` to set.</param>
        /// <returns>An `FunctionSO&lt;TR&gt;`.</returns>
        public FunctionSO<TR, T1> SetFunc(Func<T1, TR> func)
        {
            Func = func;
            return this;
        }
    }
    
    /// <summary>
    /// Generic abstract base class for Functions. Inherits from `BaseAtom`.
    /// </summary>
    /// <typeparam name="R">The type to return from the Function.</typeparam>
    /// <typeparam name="T1">The first parameter type for this Function.</typeparam>
    /// <typeparam name="T2">The second parameter type for this Function.</typeparam>
    public abstract class FunctionSO<R, T1, T2> : BaseSO
    {
        /// <summary>
        /// The actual function.
        /// </summary>
        [HideInInspector]
        public Func<T1, T2, R> Func;

        /// <summary>
        /// Call the Function.
        /// </summary>
        /// <param name="t1">The first parameter.</param>
        /// <param name="t2">The second parameter.</param>
        /// <returns>Whatever the function decides to return of type `R`.</returns>
        public virtual R Call(T1 t1, T2 t2)
        {
            if (Func != null)
            {
                return Func(t1, t2);
            }

            throw new Exception("Either set Func or override the Call method.");
        }

        /// <summary>
        /// Set the Function providing a `Func&lt;T1, T2, R&gt;`.
        /// </summary>
        /// <param name="func">The `Func&lt;T1, T2, R&gt;` to set.</param>
        /// <returns>An `AtomFunction&lt;R, T1, T2&gt;`.</returns>
        public FunctionSO<R, T1, T2> SetFunc(Func<T1, T2, R> func)
        {
            Func = func;
            return this;
        }
    }

    /// <summary>
    /// Generic abstract base class for Functions. Inherits from `BaseAtom`.
    /// </summary>
    /// <typeparam name="R">The type to return from the Function.</typeparam>
    /// <typeparam name="T1">The first parameter type for this Function.</typeparam>
    /// <typeparam name="T2">The second parameter type for this Function.</typeparam>
    /// <typeparam name="T3">The third parameter type for this Function.</typeparam>
    public abstract class FunctionSO<R, T1, T2, T3> : BaseSO
    {
        /// <summary>
        /// The actual function.
        /// </summary>
        [HideInInspector]
        public Func<T1, T2, T3, R> Func;

        /// <summary>
        /// Call the Function.
        /// </summary>
        /// <param name="t1">The first parameter.</param>
        /// <param name="t2">The second parameter.</param>
        /// <param name="t3">The third parameter.</param>
        /// <returns>Whatever the function decides to return of type `R`.</returns>
        public virtual R Call(T1 t1, T2 t2, T3 t3)
        {
            if (Func != null)
            {
                return Func(t1, t2, t3);
            }

            throw new Exception("Either set Func or override the Call method.");
        }

        /// <summary>
        /// Set the Function providing a `Func&lt;T1, T2, T3, R&gt;`.
        /// </summary>
        /// <param name="func">The `Func&lt;T1, T2, T3, R&gt;` to set.</param>
        /// <returns>An `AtomFunction&lt;R, T1, T2, T3&gt;`.</returns>
        public FunctionSO<R, T1, T2, T3> SetFunc(Func<T1, T2, T3, R> func)
        {
            Func = func;
            return this;
        }
    }

    /// <summary>
    /// Generic abstract base class for Functions. Inherits from `BaseAtom`.
    /// </summary>
    /// <typeparam name="R">The type to return from the Function.</typeparam>
    /// <typeparam name="T1">The first parameter type for this Function.</typeparam>
    /// <typeparam name="T2">The second parameter type for this Function.</typeparam>
    /// <typeparam name="T3">The third parameter type for this Function.</typeparam>
    /// <typeparam name="T4">The fourth parameter type for this Function.</typeparam>
    public abstract class FunctionSO<R, T1, T2, T3, T4> : BaseSO
    {
        /// <summary>
        /// The actual function.
        /// </summary>
        [HideInInspector]
        public Func<T1, T2, T3, T4, R> Func;

        /// <summary>
        /// Call the Function.
        /// </summary>
        /// <param name="t1">The first parameter.</param>
        /// <param name="t2">The second parameter.</param>
        /// <param name="t3">The third parameter.</param>
        /// <param name="t4">The fourth parameter.</param>
        /// <returns>Whatever the function decides to return of type `R`.</returns>
        public virtual R Call(T1 t1, T2 t2, T3 t3, T4 t4)
        {
            if (Func != null)
            {
                return Func(t1, t2, t3, t4);
            }

            throw new Exception("Either set Func or override the Call method.");
        }

        /// <summary>
        /// Set the Function providing a `Func&lt;T1, T2, T3, T4 R&gt;`.
        /// </summary>
        /// <param name="func">The `Func&lt;T1, T2, T3, T4, R&gt;` to set.</param>
        /// <returns>An `AtomFunction&lt;R, T1, T2, T3, T4&gt;`.</returns>
        public FunctionSO<R, T1, T2, T3, T4> SetFunc(Func<T1, T2, T3, T4, R> func)
        {
            Func = func;
            return this;
        }
    }

    /// <summary>
    /// Generic abstract base class for Functions. Inherits from `BaseAtom`.
    /// </summary>
    /// <typeparam name="R">The type to return from the Function.</typeparam>
    /// <typeparam name="T1">The first parameter type for this Function.</typeparam>
    /// <typeparam name="T2">The second parameter type for this Function.</typeparam>
    /// <typeparam name="T3">The third parameter type for this Function.</typeparam>
    /// <typeparam name="T4">The fourth parameter type for this Function.</typeparam>
    /// <typeparam name="T5">The fifth parameter type for this Function.</typeparam>
    public abstract class FunctionSO<R, T1, T2, T3, T4, T5> : BaseSO
    {
        /// <summary>
        /// The actual function.
        /// </summary>
        [HideInInspector]
        public Func<T1, T2, T3, T4, T5, R> Func;

        /// <summary>
        /// Call the Function.
        /// </summary>
        /// <param name="t1">The first parameter.</param>
        /// <param name="t2">The second parameter.</param>
        /// <param name="t3">The third parameter.</param>
        /// <param name="t4">The fourth parameter.</param>
        /// <param name="t5">The fifth parameter.</param>
        /// <returns>Whatever the function decides to return of type `R`.</returns>
        public virtual R Call(T1 t1, T2 t2, T3 t3, T4 t4, T5 t5)
        {
            if (Func != null)
            {
                return Func(t1, t2, t3, t4, t5);
            }

            throw new Exception("Either set Func or override the Call method.");
        }

        /// <summary>
        /// Set the Function providing a `Func&lt;T1, T2, T3, T4, T5 R&gt;`.
        /// </summary>
        /// <param name="func">The `Func&lt;T1, T2, T3, T4, T5, R&gt;` to set.</param>
        /// <returns>An `AtomFunction&lt;R, T1, T2, T3, T4, T5&gt;`.</returns>
        public FunctionSO<R, T1, T2, T3, T4, T5> SetFunc(Func<T1, T2, T3, T4, T5, R> func)
        {
            Func = func;
            return this;
        }
    }
}