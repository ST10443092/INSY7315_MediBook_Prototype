document.querySelectorAll('.appointment-actions form').forEach((form) => {
    form.addEventListener('submit', (event) => {
        event.preventDefault();
        const row = form.closest('.appointment-row');
        const nextStatus = form.querySelector('[name="status"]').value;
        const badge = row.querySelector('.appointment-status');
        badge.textContent = nextStatus;
        badge.className = `appointment-status ${nextStatus.toLowerCase()}`;
        row.querySelector('.appointment-actions').innerHTML = '<small>Demo status updated</small>';
    });
});

const availabilityForm = document.querySelector('.portal-hero form');
if (availabilityForm) {
    availabilityForm.addEventListener('submit', (event) => {
        event.preventDefault();
        const button = availabilityForm.querySelector('.availability-toggle');
        const isOnline = button.classList.toggle('online');
        button.classList.toggle('offline', !isOnline);
        button.lastChild.textContent = isOnline ? 'Accepting appointments' : 'Not accepting appointments';
        const status = document.querySelector('.status-word');
        if (status) status.textContent = isOnline ? 'Open' : 'Paused';
    });
}
