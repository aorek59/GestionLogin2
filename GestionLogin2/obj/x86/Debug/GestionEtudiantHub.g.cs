﻿#pragma checksum "D:\Verdier Arthur\Source\Repos\GestionLogin2\GestionLogin2\GestionEtudiantHub.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "022D685A71EB975AED069B2EEE04743B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GestionLogin2
{
    partial class GestionEtudiantHub : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        internal class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Windows_UI_Xaml_Controls_TextBlock_Text(global::Windows.UI.Xaml.Controls.TextBlock obj, global::System.String value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = targetNullValue;
                }
                obj.Text = value ?? global::System.String.Empty;
            }
        };

        private class GestionEtudiantHub_obj20_Bindings :
            global::Windows.UI.Xaml.IDataTemplateExtension,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IGestionEtudiantHub_Bindings
        {
            private global::GestionLogin2.Models.Salle dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);
            private bool removedDataContextHandler = false;

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.TextBlock obj21;

            public GestionEtudiantHub_obj20_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 21:
                        this.obj21 = (global::Windows.UI.Xaml.Controls.TextBlock)target;
                        break;
                    default:
                        break;
                }
            }

            public void DataContextChangedHandler(global::Windows.UI.Xaml.FrameworkElement sender, global::Windows.UI.Xaml.DataContextChangedEventArgs args)
            {
                 global::GestionLogin2.Models.Salle data = args.NewValue as global::GestionLogin2.Models.Salle;
                 if (args.NewValue != null && data == null)
                 {
                    throw new global::System.ArgumentException("Incorrect type passed into template. Based on the x:DataType global::GestionLogin2.Models.Salle was expected.");
                 }
                 this.SetDataRoot(data);
                 this.Update();
            }

            // IDataTemplateExtension

            public bool ProcessBinding(uint phase)
            {
                throw new global::System.NotImplementedException();
            }

            public int ProcessBindings(global::Windows.UI.Xaml.Controls.ContainerContentChangingEventArgs args)
            {
                int nextPhase = -1;
                switch(args.Phase)
                {
                    case 0:
                        nextPhase = -1;
                        this.SetDataRoot(args.Item as global::GestionLogin2.Models.Salle);
                        if (!removedDataContextHandler)
                        {
                            removedDataContextHandler = true;
                            ((global::Windows.UI.Xaml.Controls.StackPanel)args.ItemContainer.ContentTemplateRoot).DataContextChanged -= this.DataContextChangedHandler;
                        }
                        this.initialized = true;
                        break;
                }
                this.Update_((global::GestionLogin2.Models.Salle) args.Item, 1 << (int)args.Phase);
                return nextPhase;
            }

            public void ResetTemplate()
            {
            }

            // IGestionEtudiantHub_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // GestionEtudiantHub_obj20_Bindings

            public void SetDataRoot(global::GestionLogin2.Models.Salle newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::GestionLogin2.Models.Salle obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Name(obj.Name, phase);
                    }
                }
            }
            private void Update_Name(global::System.String obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_TextBlock_Text(this.obj21, obj, null);
                }
            }
        }

        private class GestionEtudiantHub_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IGestionEtudiantHub_Bindings
        {
            private global::GestionLogin2.GestionEtudiantHub dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.GridView obj2;

            public GestionEtudiantHub_obj1_Bindings()
            {
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2:
                        this.obj2 = (global::Windows.UI.Xaml.Controls.GridView)target;
                        break;
                    default:
                        break;
                }
            }

            // IGestionEtudiantHub_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
            }

            // GestionEtudiantHub_obj1_Bindings

            public void SetDataRoot(global::GestionLogin2.GestionEtudiantHub newDataRoot)
            {
                this.dataRoot = newDataRoot;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::GestionLogin2.GestionEtudiantHub obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_Salles(obj.Salles, phase);
                    }
                }
            }
            private void Update_Salles(global::System.Collections.Generic.List<global::GestionLogin2.Models.Salle> obj, int phase)
            {
                if((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj2, obj, null);
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2:
                {
                    global::Windows.UI.Xaml.Controls.GridView element2 = (global::Windows.UI.Xaml.Controls.GridView)(target);
                    #line 20 "..\..\..\GestionEtudiantHub.xaml"
                    ((global::Windows.UI.Xaml.Controls.GridView)element2).ItemClick += this.GridView_ItemClick;
                    #line default
                }
                break;
            case 3:
                {
                    global::Windows.UI.Xaml.Controls.ComboBox element3 = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                    #line 30 "..\..\..\GestionEtudiantHub.xaml"
                    ((global::Windows.UI.Xaml.Controls.ComboBox)element3).SelectionChanged += this.ComboBox_SelectionChanged;
                    #line default
                }
                break;
            case 4:
                {
                    this.Ok = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 5:
                {
                    this.Huit = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 6:
                {
                    this.Neuf = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 7:
                {
                    this.Dix = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 8:
                {
                    this.Onze = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 9:
                {
                    this.Douze = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 10:
                {
                    this.Treize = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 11:
                {
                    this.Quatorze = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 12:
                {
                    this.Quinze = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 13:
                {
                    this.Seize = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 14:
                {
                    this.DixSept = (global::Windows.UI.Xaml.Controls.CheckBox)(target);
                }
                break;
            case 15:
                {
                    this.SalleResult = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            case 16:
                {
                    this.Ajouter = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 17:
                {
                    this.Modifier = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 18:
                {
                    this.Supprimer = (global::Windows.UI.Xaml.Controls.Button)(target);
                }
                break;
            case 19:
                {
                    this.ComboBoxResultTextBlock = (global::Windows.UI.Xaml.Controls.TextBlock)(target);
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1:
                {
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    GestionEtudiantHub_obj1_Bindings bindings = new GestionEtudiantHub_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                }
                break;
            case 20:
                {
                    global::Windows.UI.Xaml.Controls.StackPanel element20 = (global::Windows.UI.Xaml.Controls.StackPanel)target;
                    GestionEtudiantHub_obj20_Bindings bindings = new GestionEtudiantHub_obj20_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot((global::GestionLogin2.Models.Salle) element20.DataContext);
                    element20.DataContextChanged += bindings.DataContextChangedHandler;
                    global::Windows.UI.Xaml.DataTemplate.SetExtensionInstance(element20, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}

