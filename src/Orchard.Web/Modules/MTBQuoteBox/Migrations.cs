using System;
using System.Collections.Generic;
using System.Data;
using Orchard.ContentManagement.Drivers;
using Orchard.ContentManagement.MetaData;
using Orchard.ContentManagement.MetaData.Builders;
using Orchard.Core.Contents.Extensions;
using Orchard.Data.Migration;

namespace MTBQuoteBox {
    public class Migrations : DataMigrationImpl {

        public int Create()
        {
            // Creating table MTBQuoteBoxPartRecord
            SchemaBuilder.CreateTable("MTBQuoteBoxPartRecord", table => table
                .ContentPartRecord()
                .Column("MainBody", DbType.String)
                .Column("Author", DbType.String)
            );

            ContentDefinitionManager.AlterPartDefinition("MTBQuoteBoxPartRecord",
                builder => builder.Attachable());

            return 1;
        }

        public int UpdateFrom1()
        {
            ContentDefinitionManager.AlterTypeDefinition(
                "MTBQuoteBoxWidget", cfg => cfg
                    .WithPart("MTBQuoteBoxPart")
                    .WithPart("WidgetPart")
                    .WithPart("CommonPart")
                    .WithSetting("Stereotype", "Widget"));

            return 2;
        }

        public int UpdateFrom2()
        {
            // Creating table MTBQuoteBoxPartRecord
            SchemaBuilder.CreateTable("MTBQuoteBoxPartRecord", table => table
                .ContentPartRecord()
                .Column("MainBody", DbType.String)
                .Column("Author", DbType.String)
            );

            ContentDefinitionManager.AlterPartDefinition("MTBQuoteBoxPartRecord",
                builder => builder.Attachable());

            return 3;
        }
    }
}