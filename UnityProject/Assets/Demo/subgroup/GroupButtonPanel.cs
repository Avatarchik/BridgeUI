﻿using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.Events;
using UnityEngine.Sprites;
using UnityEngine.Scripting;
using UnityEngine.Assertions;
using UnityEngine.EventSystems;
using UnityEngine.Assertions.Must;
using UnityEngine.Assertions.Comparers;
using System.Collections;
using System.Collections.Generic;

namespace BridgeUI.Common
{
    public class GroupButtonPanel : ButtonsPanel
    {
        [SerializeField]
        private Transform content;
        public override Transform Content { get { return content == null ? Group.Trans : content; } }
    }
}
