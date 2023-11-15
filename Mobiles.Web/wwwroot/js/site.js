/**
 * Function used to initialize datatables.
 * Should be used on table DOM elements.
 * 
 * DataTables and jQuery should be defined
 * 
 * @param {HTMLTableElement} table
 */
async function setupTable(table) {
    console.debug(`Setting up table: ${table}`);
    console.debug(table);
    console.debug(">>> Marking table as dataTable.");
    console.debug(new DataTable(table));
}

try {
    $(document).ready(async () => {
        console.debug("Document loading finished :: Running post setup scripts");
        const dtables = $(".datatable").toArray();
        console.debug(">>> Setting up datatables ...");
        dtables.filter(el => el instanceof HTMLTableElement).forEach(await setupTable);
    })
}
catch (err) {
    console.error(err);
}
