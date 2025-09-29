using System;
using System.Collections.Generic;

namespace Platy.AdventureWorks.Entities;

/// <summary>
/// Entity class representing data for table 'BusinessEntityContact'.
/// </summary>
[System.ComponentModel.DataAnnotations.Schema.Table("BusinessEntityContact", Schema = "Person")]
public partial class BusinessEntityContact
{
    /// <summary>
    /// Initializes a new instance of the <see cref="BusinessEntityContact"/> class.
    /// </summary>
    public BusinessEntityContact()
    {
        #region Generated Constructor
        #endregion
    }

    #region Generated Properties
    /// <summary>
    /// Gets or sets the property value representing column 'BusinessEntityID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'BusinessEntityID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("BusinessEntityID", TypeName = "int")]
    public int BusinessEntityID { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'PersonID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'PersonID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("PersonID", TypeName = "int")]
    public int PersonID { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ContactTypeID'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ContactTypeID'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Key()]
    [System.ComponentModel.DataAnnotations.Schema.Column("ContactTypeID", TypeName = "int")]
    public int ContactTypeID { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'rowguid'.
    /// </summary>
    /// <value>
    /// The property value representing column 'rowguid'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("rowguid", TypeName = "uniqueidentifier")]
    public Guid Rowguid { get; set; }

    /// <summary>
    /// Gets or sets the property value representing column 'ModifiedDate'.
    /// </summary>
    /// <value>
    /// The property value representing column 'ModifiedDate'.
    /// </value>
    [System.ComponentModel.DataAnnotations.Schema.Column("ModifiedDate", TypeName = "datetime")]
    public DateTime ModifiedDate { get; set; }

    #endregion

    #region Generated Relationships
    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="BusinessEntity" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="BusinessEntity" />.
    /// </value>
    /// <seealso cref="BusinessEntityID" />
    public virtual BusinessEntity BusinessEntity { get; set; } = null!;

    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="ContactType" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="ContactType" />.
    /// </value>
    /// <seealso cref="ContactTypeID" />
    public virtual ContactType ContactType { get; set; } = null!;

    /// <summary>
    /// Gets or sets the navigation property for entity <see cref="Person" />.
    /// </summary>
    /// <value>
    /// The navigation property for entity <see cref="Person" />.
    /// </value>
    /// <seealso cref="PersonID" />
    public virtual Person Person { get; set; } = null!;

    #endregion

}
