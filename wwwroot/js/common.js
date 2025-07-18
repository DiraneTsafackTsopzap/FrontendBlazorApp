

window.FonctionShowSwal = (type, message) => {
    if (type === "success") {
        Swal.fire({
            icon: 'success',
            title: 'Succès',
            text: message,
        });
    }
    if (type === "error") {
        Swal.fire({
            icon: 'error',
            title: 'Erreur',
            text: message,
        });
    }
    if (type === "info") {
        Swal.fire({
            icon: 'info',
            title: 'Information',
            text: message,
        });
    }
};