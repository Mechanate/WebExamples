using System;
using System.Collections.Generic;
using System.Text;
using SampleXamarinMDP.Domain.Model;
using TinyMessenger;

namespace SampleXamarinMDP.UI.Messages
{
    public class ChangeDetailPageRecipeMessage : ITinyMessage
    {
        public ChangeDetailPageRecipeMessage(Recipe recipe, object sender)
        {
            Recipe = recipe;
            Sender = sender;
        }

        public Recipe Recipe
        {
            get;
            private set;
        }

        public object Sender
        {
            get;
            private set;
        }
    }
}
