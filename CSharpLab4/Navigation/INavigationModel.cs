﻿namespace CSharpLab4.Navigation
{
    internal enum ViewType
    {
        UserAdding,
        UsersTable,
        UserEditing
    }

    interface INavigationModel
    {
        void Navigate(ViewType viewType);
    }
}
