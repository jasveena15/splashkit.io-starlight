from splashkit import *


prompt = "Explain recursion in one short paragraph."

write_line("Prompt:")
write_line(prompt)
write_line("")
write_line("AI reply:")

reply = generate_reply(prompt)

write_line(reply)
