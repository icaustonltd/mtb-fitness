using System;
using System.Collections.Generic;
using System.Data;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace MTBSlider {
    public class Migrations : DataMigrationImpl {

        public int Create() {

            // Creating table MTBSliderPartRecord

            SchemaBuilder.CreateTable("MTBSliderPartRecord", 
                table => table.ContentPartRecord()
                .Column("Image1Source", DbType.String)
                .Column("Image2Source", DbType.String)
                .Column("Image3Source", DbType.String)
                .Column("Image4Source", DbType.String)
                );

            ContentDefinitionManager.AlterPartDefinition("MTBSliderPartRecord",
                builder => builder.Attachable());

            return 1;
        }

        public int UpdateFrom1()
        {
            ContentDefinitionManager.AlterTypeDefinition(
                "MTBSliderWidget", cfg => cfg
                .WithPart("MTBSliderPart")
                .WithPart("WidgetPart")
                .WithPart("CommonPart")
                .WithSetting("Stereotype", "Widget"));

            return 2;
        }

        public int UpdateFrom2()
        {
            SchemaBuilder.AlterTable("MTBSliderPartRecord", table => table.AddColumn("Item1Title", DbType.String));
            SchemaBuilder.AlterTable("MTBSliderPartRecord", table => table.AddColumn("Item1Text", DbType.String));

            SchemaBuilder.AlterTable("MTBSliderPartRecord", table => table.AddColumn("Item2Title", DbType.String));
            SchemaBuilder.AlterTable("MTBSliderPartRecord", table => table.AddColumn("Item2Text", DbType.String));

            SchemaBuilder.AlterTable("MTBSliderPartRecord", table => table.AddColumn("Item3Title", DbType.String));
            SchemaBuilder.AlterTable("MTBSliderPartRecord", table => table.AddColumn("Item3Text", DbType.String));

            SchemaBuilder.AlterTable("MTBSliderPartRecord", table => table.AddColumn("Item4Title", DbType.String));
            SchemaBuilder.AlterTable("MTBSliderPartRecord", table => table.AddColumn("Item4Text", DbType.String));

            ContentDefinitionManager.AlterPartDefinition("MTBSliderPartRecord",
                builder => builder.Attachable());

            return 3;
        }
    }
}