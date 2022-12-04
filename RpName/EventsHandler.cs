using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System.Linq;
using System.Text.RegularExpressions;

namespace RpName
{
    public class EventsHandler
    {

        public void AttachEvent()
        {
            Exiled.Events.Handlers.Player.ChangingRole += OnChangingRole;
            Log.Warn("Attach");
        }

        public void DettachEvent()
        {
            Exiled.Events.Handlers.Player.ChangingRole -= OnChangingRole;
        }

        private void OnChangingRole(ChangingRoleEventArgs ev)
        {
            if (PluginClass.Instance.Config.RoleNames != null && PluginClass.Instance.Config.RoleNames.Any())
            {
                var id = ev.NewRole;

                if (PluginClass.Instance.Config.KeepNameTuto && id == RoleType.Tutorial)      return;
                if (PluginClass.Instance.Config.KeepNameSpectate && id == RoleType.Spectator) return;

                var name = PluginClass.Instance.GetName(id, ev.Player.Nickname);

                if (string.IsNullOrEmpty(name))
                    ev.Player.DisplayNickname = null;
                else
                    ev.Player.DisplayNickname = name;
            }
        }

    }
}