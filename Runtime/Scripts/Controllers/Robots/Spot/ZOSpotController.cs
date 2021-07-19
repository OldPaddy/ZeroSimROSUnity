using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZO.Util;
using ZO.Physics;
using ZO.Sensors;
using ZO.ROS.Publisher;

namespace ZO.Controllers {

    [RequireComponent(typeof(ZOROSJointStatesPublisher))]
    public class ZOSpotController : ZOGameObjectBase {

        

        protected override void ZOOnValidate() {
            base.ZOOnValidate();
            UpdateRateHz = 50;
        }
        protected override void ZOStart() {
            base.ZOStart();


        }



        protected override void ZOUpdate() {
            base.ZOUpdate();


        }

        protected override void ZOFixedUpdate() {
            base.ZOFixedUpdate();


        }

        protected override void ZOUpdateHzSynchronized() {
            base.ZOUpdateHzSynchronized();
        }



        protected override void ZOOnGUI() {

        }
    }
}