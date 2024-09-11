import random 
from sympy import isprime, mod_inverse 
import tkinter as tk
from tkinter import messagebox 
from tkinter import ttk 


# prime number generating 
def generate_prime_candidate(length):
    p = 0
    while not isprime(p):
        p = random.getrandbits(length) 
    return p 


# RSA key generating 
def generate_keys(bit_length=16):
    p = generate_prime_candidate(bit_length) 
    q = generate_prime_candidate(bit_length) 
    N = p * q 
    phi = (p - 1) * (q - 1) 

    e = random.randint(2, phi - 1) 
    while gcd(e, phi) != 1:
        e = random.randint(2, phi - 1) 
    
    d = mod_inverse(e, phi) 

    return (e, N), (d, N) 


# greatest common divisor (GCD) 
def gcd(a, b):
    while b:
        a, b = b, a % b 
    return a 


# encrypting the message
def encrypt(message, public_key):
    e, N = public_key 
    encrypted_message = pow(message, e, N) 
    return encrypted_message 


# decrypting the message
def decrypt(encrypted_message, private_key):
    d, N = private_key 
    decrypted_message = pow(encrypted_message, d, N) 
    return decrypted_message 


# decrypting the message with enumeration 
def brute_force_decrypt(encrypted_message, e, N):
    for possible_message in range(1000, 10000):
        if pow(possible_message, e, N) == encrypted_message:
            return possible_message
    return None 


# visualization 
def visualize_process(message, encrypted_message, decrypted_message, brute_force_message):
    result_window = tk.Toplevel() 
    result_window.title("RSA Visualization Results") 

    frame = ttk.Frame(result_window, padding="10") 
    frame.pack(fill=tk.BOTH, expand=True) 

    ttk.Label(frame, text=f"Original Message: {message}").pack(anchor=tk.W, pady=2)
    ttk.Label(frame, text=f"Encrypted Message: {encrypted_message}").pack(anchor=tk.W, pady=2)
    ttk.Label(frame, text=f"Decrypted Message: {decrypted_message}").pack(anchor=tk.W, pady=2)
    ttk.Label(frame, text=f"Brute-forced Message: {brute_force_message}").pack(anchor=tk.W, pady=2)

    ttk.Button(frame, text="Close", command=result_window.destroy).pack(pady=10)


# interface
def start_interface():
    def process_message():
        try:
            message = int(entry_message.get()) 
            if message < 1000 or message > 10000:
                raise ValueError 
            
            public_key, private_key = generate_keys() 

            encrypted_message = encrypt(message, public_key) 
            decrypted_message = decrypt(encrypted_message, private_key) 
            brute_force_message = brute_force_decrypt(encrypted_message, public_key[0], public_key[1])
            
            visualize_process(message, encrypted_message, decrypted_message, brute_force_message)
        except ValueError:
            messagebox.showerror("Error", "Message must be an integer between 1000 and 10000")
    
    root = tk.Tk() 
    root.title("RSA Visualization") 
    root.geometry("300x200") 

    frame = ttk.Frame(root, padding="10") 
    frame.pack(fill=tk.BOTH, expand=True) 

    ttk.Label(frame, text="Enter a message (1000-10000):").pack(pady=5) 
    entry_message = ttk.Entry(frame) 
    entry_message.pack(pady=5) 

    ttk.Button(frame, text="Process", command=process_message).pack(pady=10)


    root.mainloop() 