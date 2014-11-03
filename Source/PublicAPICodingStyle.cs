using System;
using UnityEngine;

namespace UnityVRCrosshair
{
    /// <summary>
    /// All classes are capitalized. Public API classes require an XML comment with a small summary. Applying the [Serializable] attribute is optional.
    /// </summary>
    /// <remarks>
    /// The UnityVRCrosshair.Internal namespace is the only namespace not part of the public API.
    /// </remarks>
    [Serializable]
    public class PublicAPICodingStyle
    {
        // Fields are never capitalized, always private and may have C# comments, but only when necessary. Usually a good name is enough.
        private int someField;
        
        // Fields that need to be exposed to the inspector require the [SerializeField] attribute.
        [SerializeField]
        private Color someExposedField;

        /// <summary>
        /// Properties are never capitalized. Public API properties require an XML comment with a small summary.
        /// </summary>
        public bool someProperty { get; set; }

        /// <summary>
        /// Properties with a private setter are considered read-only. Useful when outside code should not set the value.
        /// </summary>
        public float someReadOnlyProperty { get; private set; }

        // Public constructors are capitalized but don't require an XML comment unless their parameters need some explaining.
        public PublicAPICodingStyle()
        {
            // The body of a constructor may contain C# comments to explain confusing lines of code
            someProperty = someExposedField == Color.blue;
        }

        // All methods are capitalized. Private methods may have C# comments, but only when necessary. Usually a good name is enough.
        private void SomeMethod()
        {
            // The body of a method may contain C# comments to explain confusing lines of code
            someField = 0;
            someReadOnlyProperty = someField * Mathf.Infinity;
        }

        /// <summary>
        /// Public API methods require an XML comment with a summary.
        /// </summary>
        /// <param name="someFlag">Parameters may be explained further, but only when necessary</param>
        /// <returns>Return values may be explained further, but only when necessary</returns>
        public string SomeComplexBranchingMethod(bool someFlag)
        {
            // Code formatting of method invocation
            SomeSimpleBranchingMethod();

            // Code formatting of complex if statement
            if (someFlag)
            {
                someExposedField = Color.red;
                return "Red";
            }
            else if (someReadOnlyProperty == 0)
            {
                someExposedField = Color.black;
                return "Total darkness";
            }
            else
            {
                return "Nothing";
            }
        }

        private string SomeSimpleBranchingMethod()
        {
            // Code formatting of simple if statement
            if (someProperty)
                return "Some string";
            else
                return "Nothing";
        }

        private void SomeLoopingMethod()
        {
            // Code formatting of while loop
            while (someProperty)
            {
                someField++;
                someProperty = UnityEngine.Random.Range(0, 1) == 1;
            }

            // Code formatting of for loop
            for (int i = 0; i < 5; i++)
            {
                someField++;
            }

            // Code formatting of foreach loop
            foreach (char c in new char[] { 'a', 'b', 'c', 'd', 'e' })
            {
                someField += (int) c;
            }
        }
    }
}