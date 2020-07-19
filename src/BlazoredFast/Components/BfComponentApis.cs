namespace SayusiAndo.Carbon.BlazoredFast.Components
{
    /// <summary>
    ///     Api and api values for Bf* components.
    /// </summary>
    public struct BfComponentApis
    {
        /// <summary>
        ///     BfAccordion component Api.
        /// </summary>
        public struct BfAccordion
        {
            public const string ExpandMode = "expand-mode";

            /// <summary>
            ///     BfAccordion Api values for configuration.
            /// </summary>
            public struct ExpandModeValues
            {
                public const string Single = "single";
                public const string Multi = "multi";
            }
        }

        public struct BfAccordionItem
        {
        }

        public struct BfTab
        {
            public struct Html
            {
                public const string BfTab = "fast-tab";
            }
        }

        public struct BfTabs
        {
            public struct Html
            {
                public const string BfTabs = "fast-tabs";
            }

            public struct Css
            {
                public struct BfTabs
                {
                    public const string Horizontal = "horizontal";
                    public const string Vertical = "vertical";
                }
            }

            public struct Attributes
            {
                public const string ActiveId = "activeid";
                public const string Orientation = "orientation";
                public const string ActiveIndicator = "activeindicator";

                public struct OrientationValues
                {
                    public const string Horizontal = "horizontal";
                    public const string Vertical = "vertical";
                }
            }
        }
    }
}