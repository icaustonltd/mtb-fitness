using System;
using System.Collections.Generic;
using System.Data;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace MTBSmallCTA {
    public class Migrations : DataMigrationImpl {

        public int Create() {
			// Creating table MTBSmallCTAPartRecord
			SchemaBuilder.CreateTable("MTBSmallCTAPartRecord", table => table
				.ContentPartRecord()
                .Column("Item1Title", DbType.String)
                .Column("Item1CSSClass", DbType.String)
			);

            ContentDefinitionManager.AlterPartDefinition("MTBSmallCTAPartRecord",
                builder => builder.Attachable());

            return 1;
        }

        public int UpdateFrom1()
        {
            ContentDefinitionManager.AlterTypeDefinition(
                "MTBSmallCTAWidget", cfg => cfg
                    .WithPart("MTBSmallCTAPart")
                    .WithPart("WidgetPart")
                    .WithPart("CommonPart")
                    .WithSetting("Stereotype", "Widget"));

            return 2;
        }

        public int UpdateFrom2()
        {
            SchemaBuilder.AlterTable("MTBSmallCTAPartRecord", table => table.AddColumn("Item2Title", DbType.String));
            SchemaBuilder.AlterTable("MTBSmallCTAPartRecord", table => table.AddColumn("Item2CSSClass", DbType.String));

            SchemaBuilder.AlterTable("MTBSmallCTAPartRecord", table => table.AddColumn("Item3Title", DbType.String));
            SchemaBuilder.AlterTable("MTBSmallCTAPartRecord", table => table.AddColumn("Item3CSSClass", DbType.String));

            ContentDefinitionManager.AlterPartDefinition("MTBSmallCTAPartRecord",
                builder => builder.Attachable());

            return 3;
        }

        public int UpdateFrom3()
        {
            ContentDefinitionManager.AlterTypeDefinition(
                "MTBSmallCTAWidget", cfg => cfg
                    .WithPart("MTBSmallCTAPart")
                    .WithPart("WidgetPart")
                    .WithPart("CommonPart")
                    .WithSetting("Stereotype", "Widget"));

            return 4;
        }

        public int UpdateFrom4()
        {
            ContentDefinitionManager.AlterTypeDefinition(
                "MTBSmallCTAWidget", cfg => cfg
                    .WithPart("MTBSmallCTAPart")
                    .WithPart("WidgetPart")
                    .WithPart("CommonPart")
                    .WithSetting("Stereotype", "Widget"));

            return 5;
        }
    }
}