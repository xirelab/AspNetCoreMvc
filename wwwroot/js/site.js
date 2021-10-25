// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

const button = document.getElementById('post-btn');

button.addEventListener('click', async _ => {
  try {
    console.log('Started!');     
    const response = await fetch('https://localhost:5001/Home/Admin', {
      method: 'post',
      body: {
        // Your body
      }
    });
    console.log('Completed!', response);
  } catch(err) {
    console.error(`Error: ${err}`);
  }
});