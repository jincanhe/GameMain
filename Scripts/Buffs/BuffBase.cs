using GameFramework;
using StarForce;

namespace GameMain.Scripts.Buffs
{
    public class BuffBase : IReference
    {
        public enum BuffType
        {
            Buff,
            DeBuff,
            None,
        }

        /// <summary>
        /// 唯一id
        /// </summary>
        public int id;

        /// <summary>
        /// 持续时间
        /// </summary>
        public int timer;

        /// <summary>
        /// 瞬发
        /// </summary>
        public bool instantaneous;

        /// <summary>
        /// buff类型
        /// </summary>
        public BuffType type;

        public TargetableObject targettbaleObject;
        public BuffBase Fill(TargetableObject targettbaleObject, int id, BuffType type, int timer, bool instantaneous)
        {
            this.targettbaleObject = targettbaleObject;
            this.id = id;
            this.type = type;
            this.timer = timer;
            this.instantaneous = instantaneous;
            return this;
        }


        public void Clear()
        {
            id = 0;
            timer = 0;
            instantaneous = false;
            type = BuffType.None;
            targettbaleObject = null;
        }

    }
}