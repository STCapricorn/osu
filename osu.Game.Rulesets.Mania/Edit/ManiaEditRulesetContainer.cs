﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using OpenTK;
using osu.Framework.Graphics.Cursor;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Mania.UI;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.Mania.Edit
{
    public class ManiaEditRulesetContainer : ManiaRulesetContainer
    {
        public ManiaEditRulesetContainer(Ruleset ruleset, WorkingBeatmap beatmap)
            : base(ruleset, beatmap)
        {
        }

        protected override Playfield CreatePlayfield() => new ManiaEditPlayfield(Beatmap.Stages);

        protected override Vector2 PlayfieldArea => Vector2.One;

        protected override CursorContainer CreateCursor() => null;
    }
}
