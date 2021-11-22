using System;
using System.ComponentModel;
using System.Diagnostics;

namespace WindowsApp7.My
{
    internal static partial class MyProject
    {
        internal partial class MyForms
        {
            [EditorBrowsable(EditorBrowsableState.Never)]
            public AboutSedge m_AboutSedge;

            public AboutSedge AboutSedge
            {
                [DebuggerHidden]
                get
                {
                    m_AboutSedge = Create__Instance__(m_AboutSedge);
                    return m_AboutSedge;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_AboutSedge))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_AboutSedge);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public BrowserForm m_BrowserForm;

            public BrowserForm BrowserForm
            {
                [DebuggerHidden]
                get
                {
                    m_BrowserForm = Create__Instance__(m_BrowserForm);
                    return m_BrowserForm;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_BrowserForm))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_BrowserForm);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public BrowserTabHandler m_BrowserTabHandler;

            public BrowserTabHandler BrowserTabHandler
            {
                [DebuggerHidden]
                get
                {
                    m_BrowserTabHandler = Create__Instance__(m_BrowserTabHandler);
                    return m_BrowserTabHandler;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_BrowserTabHandler))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_BrowserTabHandler);
                }
            }

            [EditorBrowsable(EditorBrowsableState.Never)]
            public Settings m_Settings;

            public Settings Settings
            {
                [DebuggerHidden]
                get
                {
                    m_Settings = Create__Instance__(m_Settings);
                    return m_Settings;
                }

                [DebuggerHidden]
                set
                {
                    if (ReferenceEquals(value, m_Settings))
                        return;
                    if (value is object)
                        throw new ArgumentException("Property can only be set to Nothing");
                    Dispose__Instance__(ref m_Settings);
                }
            }
        }
    }
}