using System;
using System.Collections.Generic;
using System.Data;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace MTBContactBox {
    public class Migrations : DataMigrationImpl {

        public int Create() {

            // Creating table MTBContactBoxPartRecord
            SchemaBuilder.CreateTable("MTBContactBoxPartRecord", table => table
                .ContentPartRecord()
                .Column("Title", DbType.String)
                .Column("MainBody", DbType.String)
            );

            ContentDefinitionManager.AlterPartDefinition("MTBContactBoxPartRecord",
                builder => builder.Attachable());

            return 1;
        }

        public int UpdateFrom1()
        {
            ContentDefinitionManager.AlterTypeDefinition(
                "MTBContactBoxWidget", cfg => cfg
                    .WithPart("MTBContactBoxPart")
                    .WithPart("WidgetPart")
                    .WithPart("CommonPart")
                    .WithSetting("Stereotype", "Widget"));

            return 2;
        }
    }
}