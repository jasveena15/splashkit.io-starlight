#include "splashkit.h"

int main()
{
    string prompt = "Explain recursion in one short paragraph.";

    write_line("Prompt:");
    write_line(prompt);
    write_line("");
    write_line("AI reply:");

    string reply = generate_reply(prompt);

    write_line(reply);

    return 0;
}
