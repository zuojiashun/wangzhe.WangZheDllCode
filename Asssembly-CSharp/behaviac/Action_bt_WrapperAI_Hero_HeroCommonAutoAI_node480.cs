using Assets.Scripts.GameLogic;
using System;

namespace behaviac
{
	internal class Action_bt_WrapperAI_Hero_HeroCommonAutoAI_node480 : Action
	{
		private SkillSlotType method_p0;

		public Action_bt_WrapperAI_Hero_HeroCommonAutoAI_node480()
		{
			this.method_p0 = SkillSlotType.SLOT_SKILL_0;
		}

		protected override EBTStatus update_impl(Agent pAgent, EBTStatus childStatus)
		{
			((ObjAgent)pAgent).SetSkillSpecial(this.method_p0);
			return EBTStatus.BT_SUCCESS;
		}
	}
}
